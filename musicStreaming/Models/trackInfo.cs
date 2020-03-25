using System;
namespace musicStreaming.Models
{
    public class trackInfo
    {
        public string artistName {get; set;}
        public string trackName {get; set;}
        public string albumName {get; set;}
        public string trackUrl {get; set;}
    
        public trackInfo(){}
        public trackInfo(string artist, string track, string album,string url){
        this.artistName= artist;
        this.trackName = track;
        this.albumName = album;
        this.trackUrl = url;

        }

        
    }
}