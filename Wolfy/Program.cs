using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Exceptions;
using Microsoft.Extensions.Logging;
using Wolfy.Commands;

namespace Wolfy
{
    public class Program
    {
        public static Program instance;
        public DiscordClient client;
        public CommandsNextExtension commandsNext;
        public string[] auth;

        public Program()
        {
            auth = File.ReadAllLines("Data/auth.txt");
            client = new DiscordClient(new DiscordConfiguration()
            {
                
#if DEBUG
                MinimumLogLevel = LogLevel.Debug,
#else
                MinimumLogLevel  = LogLevel.Information,
#endif
                TokenType = TokenType.Bot,
                Token = auth[0]
            });
            commandsNext = client.UseCommandsNext(new CommandsNextConfiguration()
            {
                EnableDms = false,
                EnableMentionPrefix = false,
                EnableDefaultHelp = false,
                StringPrefixes = new[] { "!" }
            });
            client.ClientErrored += Client_ClientErrored;
            AddAllModules();
        }

        private Task Client_ClientErrored(DiscordClient client, DSharpPlus.EventArgs.ClientErrorEventArgs e)
        {
            client.Logger.Log(LogLevel.Error, "DSharpPlus", "Unhandled exception - message: " + e.Exception, DateTime.Now);
            return Task.CompletedTask;
        }

        void AddAllModules()
        {
            Stopwatch stopwatch = new Stopwatch();
            client.Logger.Log(LogLevel.Information, "Wolfy Loading modules...", DateTime.Now);
            stopwatch.Start();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (typeof(BaseExtension).IsAssignableFrom(t))
                {
                    try
                    {
                        BaseExtension mod = (BaseExtension)Activator.CreateInstance(t);
                        client.AddExtension(mod);
                        client.Logger.Log(LogLevel.Debug, $"Wolfy Loaded module {t.FullName}", DateTime.Now);
                    }
                    catch (Exception e)
                    {
                        client.Logger.Log(LogLevel.Error, $"Wolfy Unhandled exception while trying to import module {t.FullName}: {e}", DateTime.Now);
                    }
                }
                else if (t.IsPublic && t.GetCustomAttribute<CommandModuleAttribute>() != null)
                {
                    try
                    {
                        commandsNext.RegisterCommands(t);
                        client.Logger.Log(LogLevel.Debug, $"Wolfy Loaded commands {t.FullName}", DateTime.Now);
                    }
                    catch (Exception e)
                    {
                        client.Logger.Log(LogLevel.Error, $"Wolfy Unhandled exception while trying to import commands {t.FullName}: {e}", DateTime.Now);
                    }
                }
            }
            stopwatch.Stop();
            client.Logger.Log(LogLevel.Information, $"Wolfy Finished loading modules in {stopwatch.ElapsedMilliseconds}ms", DateTime.Now);
        }

        public async Task StartAsync()
        {
            await client.ConnectAsync();
            await Task.Delay(-1);
        }

        static void Main(string[] args)
        {
            instance = new Program();
            instance.StartAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
