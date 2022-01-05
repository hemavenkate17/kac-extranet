using System;
using System.Threading.Tasks;
using AzureBlobStorage;


namespace AzureBlobStorage
{
    class Program
    {
        static async Task Main(string[]args)
        {
            // await AzureBlobClient.UploadBlob();
            AzureBlobClient azureBlobClient = new AzureBlobClient();
            azureBlobClient.download_FromBlob("UX Process.pdf", "new-blobcontainer");
            Console.ReadKey();

        }
    }
}
