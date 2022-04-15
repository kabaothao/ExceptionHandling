using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YoutubeApi
	{
        public List<Video> GetVideos(string user)
        {
			try
			{
				//Access to Youtube web service
				//Read the data
				//Create a list of Video objectss

			}
			catch (Exception ex)
			{

				throw;
			}

			return new List<Video>();
		}


    }
}
