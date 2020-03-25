using System;
using System.Collections.Generic;
using musicStreaming.Models;



namespace musicStreaming.Services
{
    public class DataService
    {
         public List<trackInfo> fixedData = new List<trackInfo>{
           new trackInfo ("AE, Prozax","Clamato Fever","Street Fighter 2","http://www.jateam.azurewebsites.net/music/Street_Fighter_2_Clamato_Fever_OC_ReMix.mp3"),
           new trackInfo ("AE1, Prozax1","Clamato Fever1","Street Fighter 21","http://www.jateam.azurewebsites.net/music/Street_Fighter_21_Clamato_Fever_OC_ReMix.mp3")

     };
     public IEnumerable<trackInfo>GetTracks(){
         return fixedData;
     }
    }
}