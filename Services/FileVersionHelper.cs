namespace ExpertPlanner.Services
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using Microsoft.AspNetCore.Hosting;

    public class FileVersionHelper
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        public FileVersionHelper(IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment ?? throw new ArgumentNullException(nameof(hostingEnvironment));
        }

        public string GetFileVersion(string filePath)
        {
            string fullPath = Path.Combine(hostingEnvironment.ContentRootPath, filePath);

            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(fullPath))
            {
                var hashBytes = md5.ComputeHash(stream);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }

}
