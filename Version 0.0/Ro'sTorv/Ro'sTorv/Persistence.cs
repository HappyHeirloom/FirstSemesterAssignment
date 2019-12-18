using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;

namespace RosTorv
{
    class Persistence
    {
        string fileName = "TextFile1.txt";
        public string HighscoreName = "";
        public string HighscoreScore = "";
        private string folder = Environment.CurrentDirectory;
        private static string path = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        private string downloadpath = Path.Combine(path, "Downloads");


        public Persistence()
        {

        }

        public async void CreateFile()
        {
        }

        public async void SaveScore(string Name, string Score)
        {
            //CreateFile();
            string username = Name;
            string userscore = Score;

            //Windows.Storage.StorageFolder storageFolder =
            //    Windows.Storage.ApplicationData.Current.LocalFolder;
            //Windows.Storage.StorageFile sampleFile =
            //    await storageFolder.GetFileAsync("TextFile1.txt");

            //await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "Hej");
            StorageFile file = await Windows.Storage.DownloadsFolder.CreateFileAsync("TextFile1.txt", CreationCollisionOption.GenerateUniqueName);


            using (StreamWriter writer = new StreamWriter(await file.OpenStreamForWriteAsync()))
            {
                await writer.WriteLineAsync(username);
                await writer.WriteLineAsync(userscore);
                await writer.FlushAsync();
            }

            MessageDialog msg = new MessageDialog($"Score has been saved in file as: {username}" + $"{userscore} ");
            await msg.ShowAsync();
        }

        public async void LoadScore()
        {
            //Windows.Storage.StorageFolder storageFolder =
            //    Windows.Storage.ApplicationData.Current.LocalFolder;
            //Windows.Storage.StorageFile sampleFile =
            //    await storageFolder.GetFileAsync("TextFile1.txt");

            //HighscoreName = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            //HighscoreScore = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///" + fileName));
            using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
            {
                HighscoreName = reader.ReadLine();
                HighscoreScore = reader.ReadLine();
            }

            //MessageDialog msg = new MessageDialog(HighscoreName + HighscoreScore);
            //await msg.ShowAsync();
        }

    }
}
