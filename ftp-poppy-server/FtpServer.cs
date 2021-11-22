using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FubarDev.FtpServer;
using FubarDev.FtpServer.FileSystem.DotNet;

using Microsoft.Extensions.DependencyInjection;


namespace ftp_poppy_server
{
    class FtpServer
    {
        ServiceProvider serviceProvider;
        IFtpServerHost ftpServerHost;
        ServiceCollection services;

        ushort port;
        string folderPath;

        public FtpServer(string folderPath, ushort port=21)
        {
            if (Directory.Exists(folderPath))
            {
                this.folderPath = folderPath;
            }
            else
            {
                throw new DirectoryNotFoundException("Provided folder path is not valid");
            }
            this.port = port;
            Setup();
        }
        void Setup()
        {

            // Setup dependency injection
            services = new ServiceCollection();

            // set up a root folder
            services.Configure<DotNetFileSystemOptions>(opt => opt
                .RootPath = folderPath);

            // Add FTP server services
            // DotNetFileSystemProvider = Use the .NET file system functionality
            // AnonymousMembershipProvider = allow only anonymous logins
            services.AddFtpServer(builder => builder
                .UseDotNetFileSystem() // Use the .NET file system functionality
                .EnableAnonymousAuthentication()); // allow anonymous logins
            


            // Configure the FTP server
            services.Configure<FtpServerOptions>(opt => { opt.ServerAddress = "127.0.0.1";
                opt.Port = this.port;
            });
            serviceProvider = services.BuildServiceProvider();
        }
        public void Run()
        {
            // Initialize the FTP server
            ftpServerHost = serviceProvider.GetRequiredService<IFtpServerHost>();

            // Start the FTP server
            ftpServerHost.StartAsync();           

        }

        public void Stop() {
            // Stop the FTP server
             ftpServerHost.StopAsync();
        }
    }
}

