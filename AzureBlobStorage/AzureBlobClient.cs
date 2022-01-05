using Azure.Storage.Blobs;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobStorage
{
    public class AzureBlobClient
    {

        public static async Task UploadBlob()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=kacfceusdevsa;AccountKey=8PDy6d2KqNtniz07ewQ9Cs0VqvrTJIDm02m6pSaCtRMlDt9xj4Nyes5FrJEkD+4018406Koi9CAih+Qzh85/Qw==;EndpointSuffix=core.windows.net";
            string containerName = "new-blobcontainer";
            try
            {
                var serviceClient = new BlobServiceClient(connectionString);
                var containerClient = serviceClient.GetBlobContainerClient(containerName);
                var path = @"C:\Users\HemalathaV\Downloads";
                var fileName = "UX Process.pdf";
                var localFile = Path.Combine(path, fileName);
                await File.WriteAllTextAsync(localFile, "This is a test pdf");
                var blobClient = containerClient.GetBlobClient(fileName);
                Console.WriteLine("Uploading to Blob storage");
                using FileStream uploadFileStream = File.OpenRead(localFile);
                await blobClient.UploadAsync(uploadFileStream, true);
                uploadFileStream.Close();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void download_FromBlob(string filetoDownload, string azure_ContainerName)
        {
            Console.WriteLine("Inside downloadfromBlob()");

            string storageAccount_connectionString = "DefaultEndpointsProtocol=https;AccountName=kacfceusdevsa;AccountKey=8PDy6d2KqNtniz07ewQ9Cs0VqvrTJIDm02m6pSaCtRMlDt9xj4Nyes5FrJEkD+4018406Koi9CAih+Qzh85/Qw==;EndpointSuffix=core.windows.net";

            try
            {
                CloudStorageAccount mycloudStorageAccount = CloudStorageAccount.Parse(storageAccount_connectionString);
                CloudBlobClient blobClient = mycloudStorageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClient.GetContainerReference(azure_ContainerName);
                CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(filetoDownload);

                Stream file = File.OpenWrite(@"D:\Softura personal\" + filetoDownload);

                cloudBlockBlob.DownloadToStreamAsync(file);

                Console.WriteLine("Download completed!");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
