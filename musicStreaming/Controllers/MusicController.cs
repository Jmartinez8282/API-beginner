using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using musicStreaming.Models;
using musicStreaming.Services;

namespace musicStreaming.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MusicController
    {
        readonly DataService _fixedData;
       public MusicController(DataService fixedData){
           _fixedData = fixedData;
       }
       //create an object an array of objects
       //Object will be based on Model trackInfo
   [HttpGet] 
       public IEnumerable<trackInfo> Get(){
        return _fixedData.GetTracks();
       }
       [HttpGet("artist")]
       public string GetArtistName(){
           return "jateam";

       }
    
    }
}