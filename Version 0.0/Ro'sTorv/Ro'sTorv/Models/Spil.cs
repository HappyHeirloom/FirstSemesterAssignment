using System;
using System.IO;
using System.Runtime;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace RosTorv.Models
{
    class Spil
    {
        public Spil()
        {
            
        }

        public async void CreateFile()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync("sample.txt", 
                Windows.Storage.CreationCollisionOption.ReplaceExisting);
        }

        public async void WriteToFile()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("sample.txt");

            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "Swift as a shadow");
        }

        public async void ReadFile()
        {
            string fileName = "TextFile1.txt";
            string content = "";

            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///" + fileName));
            using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
            {
                content = reader.ReadToEnd();
            }

            MessageDialog msg = new MessageDialog(content);
            await msg.ShowAsync();

        }
    }
}
