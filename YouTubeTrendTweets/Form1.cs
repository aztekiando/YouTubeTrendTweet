using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Parameters;

namespace YouTubeTrendTweets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async() => 
            {

                try
                {
                    var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                    {
                        ApiKey = txtYTKey.Text,
                        ApplicationName = "YouTubeTrendTweet",

                    });
                    var videoMain = youtubeService.Videos.List("statistics,snippet");   // İstatistik ve snippet verilerini çektik. 
                    videoMain.Chart = VideosResource.ListRequest.ChartEnum.MostPopular;
                    string tweetText = "";
                    if (txtRegionCode.Text != "")  // Text boşsa varsayılan olarak arama yapar.
                    {
                        videoMain.RegionCode = txtRegionCode.Text;
                        tweetText = "Most Pupular 3 Videos in "+txtRegionCode.Text+"; \n";
                    }
                    else
                    {
                        tweetText = "Most Pupular 3 Videos; \n";
                    }
                    
                    videoMain.MaxResults = 3;  
                    var populerVideo = await videoMain.ExecuteAsync();  
                    
                    int index = 1;
                    foreach (var video in populerVideo.Items)
                    {
                        string viewcount = String.Format("{0:N}", video.Statistics.ViewCount);
                        viewcount = viewcount.Replace(",00", "");
                        tweetText += index + ". Video: " + video.Snippet.Title + " (" + viewcount + ") \n";  // Video başlığını ve İzlenme sayılarını yazdırdık.
                        index++;
                    }

                    WebClient client = new WebClient();
                    client.DownloadFile(new Uri(populerVideo.Items[0].Snippet.Thumbnails.Standard.Url), Application.StartupPath + @"\" + @"mostPopular");  //1. Videonun küçük resmini indiriyoruz. 
                    client.Dispose();

                    var user = new TwitterClient(txtTWConKey.Text, txtTWConSec.Text, txtTWAccToken.Text, txtTWAccSec.Text);  
                    var binary = File.ReadAllBytes(Application.StartupPath + @"\" + @"mostPopular");
                    var image = await user.Upload.UploadTweetImageAsync(binary);
                    var tweetWithImage = await user.Tweets.PublishTweetAsync(new PublishTweetParameters(tweetText) // Resimli tweet atıyoruz.
                    {
                        Medias = { image }
                    });


                    MessageBox.Show("Tweet Shared");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            });
        }
    }
}
