using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Azure.Storage.Blobs;
using static System.Net.WebRequestMethods;
using File = System.IO.File;


//DefaultEndpointsProtocol = https; AccountName = timstorageforsite; AccountKey = RTK7MO9Nc7OBoASczx7FnROoqTbQXXijpJ5k4D9w3qABwG9 / DOO6VptRKIXZWBHhvjl4fRl6oAyY + AStmyvGNQ ==; EndpointSuffix = core.windows.net
//fileupload


Console.WriteLine("enter connection string ");
string BlobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=timstorageforsite;AccountKey=RTK7MO9Nc7OBoASczx7FnROoqTbQXXijpJ5k4D9w3qABwG9/DOO6VptRKIXZWBHhvjl4fRl6oAyY+AStmyvGNQ==;EndpointSuffix=core.windows.net";
Console.WriteLine("enter containet name ");

string BlobStorageContainerName = Console.ReadLine();
;
List<string> strings = new List<string>();

var backupBlobClient = CloudStorageAccount.Parse(BlobStorageConnectionString).CreateCloudBlobClient();
var backupContainer = backupBlobClient.GetContainerReference(BlobStorageContainerName);

BlobServiceClient blobServiceClient = new BlobServiceClient(BlobStorageConnectionString);
BlobContainerClient cont = blobServiceClient.GetBlobContainerClient("fileupload");
//cont.GetBlobClient("image2.jpg").DeleteIfExists();
var container = new BlobContainerClient(BlobStorageConnectionString, BlobStorageContainerName);
//backupContainer.ListBlobs().OfType<CloudBlockBlob>().Select(b => b.Name.Equals(n).
//backupContainer.DeleteAsync();


while (true)
{
    Console.WriteLine("chose command: \n1 - check if file exists \n2 - delete file \n3 - add file \n4 - show files\n5 - show dirictories\n0 - break");
    int a = int.Parse(Console.ReadLine());
    if(a == 1)
    {
        Console.WriteLine("enter file name ");
        string name = Console.ReadLine();
        if (cont.GetBlobClient(name).Exists())
        {
            Console.WriteLine("exists");
        }
        else
        {
            Console.WriteLine("not exists");
        }
    }
    else if( a == 2)
    {
        Console.WriteLine("enter file name ");
        string name = Console.ReadLine();
        cont.GetBlobClient(name).DeleteIfExists();
       
        Console.WriteLine("done");
    }
    else if (a == 3)
    {
        Console.WriteLine("enter file path");
        string path = Console.ReadLine();
        Console.WriteLine("enter file name");
        string name = Console.ReadLine();
        var blob = container.GetBlobClient(name);

        var stream = File.OpenRead(path);
        await blob.UploadAsync(stream);
        Console.WriteLine("Upload completed.");

    }
    else if (a == 4)
    {
        var listName = backupContainer.ListBlobs().OfType<CloudBlockBlob>().Select(b => b.Name).ToList();
       
        foreach (var item in listName)
        {

            FileInfo fileInfo = new FileInfo(item);
            
            strings.Add($"Name: {fileInfo.Name} / Extension: {fileInfo.Extension}");
        }

        foreach (string b in strings)
        {
            Console.WriteLine(b);
        }
    }
    else if(a == 5)
    {
        var listName2 = backupContainer.ListBlobs().OfType<CloudBlobDirectory>().Select(b => b).ToList();
        Console.WriteLine(listName2);
    }
   
    else if(a == 0)
    {
        break;
    }
}



