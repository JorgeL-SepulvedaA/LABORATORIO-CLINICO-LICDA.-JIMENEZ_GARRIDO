using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Azure.Storage.Blobs;

namespace BusinessLayer
{
    public class FileContainerManagement
    {
        public string FileUP(string file)
        {
            //getting a building path
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            //getting containig methods
            BlobContainerClient containerClient = new BlobContainerClient(configuration.GetConnectionString("StorageAccount"), "LabClinico_Info_Container"); //this one works with de conection string and a name for the container stuff
            containerClient.CreateIfNotExists(); //in this one line we create a container client

            BlobClient blobClient = containerClient.GetBlobClient(file);
            blobClient.Upload(file);

            return blobClient.ToString();
        }
    }
}
