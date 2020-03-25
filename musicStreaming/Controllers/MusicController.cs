using System;
using Microsoft.AspNetCore.Mvc;
using musicStreaming.Models;

namespace musicStreaming.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MusicController
    {
       //create an object an array of objects
       //Object will be based on Model trackInfo
    private static readonly trackInfo[] tracks = new trackInfo[]
    
    
{
            title:'Champion Edition Credits Theme (One Credit Finish Mix)',
            artist:'Rayza',
            game:'Street Fighter 2 Champion Edition',
            playlist:'Street Fighter',
            url:'http: // www.jateam.azurewebsites.net/music/Street_Fighter_2_CE_Credits_Theme_(One_Credit_Finish_Mix)_OC_ReMix.mp3'
        },
        {
            title:'China Street Beat',
            artist:'McVaffe',
            game:'Street Fighter 2',
            playlist:'Street Fighter',
            url:'http: // www.jateam.azurewebsites.net/music/Street_Fighter_2_China_Street_Beat_OC_ReMix.mp3'
        },
        {
            title:'Clamato Fever',
            artist:'AE, Prozax',
            game:'Street Fighter 2',
            playlist:'Street Fighter',
            url:'http: // www.jateam.azurewebsites.net/music/Street_Fighter_2_Clamato_Fever_OC_ReMix.mp3'
        },
    

 [HttpGet] 
       public string Get(){

       }
    }
}