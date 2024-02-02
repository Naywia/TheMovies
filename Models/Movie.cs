using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Movie
    {
        private string title;
        private string runTime;
        private List<string> genres;
        private string producer;
        private DateTime releaseDate;
        private DateTime showTime;

        public string Title {  get { return title; } set {  title = value; } }
        public string RunTime { get {  return runTime; } set {  runTime = value; } }
        public List<string> Genres { get {  return genres; } set {  genres = value; } }
        public string Producer { get { return producer;} set { producer = value; } }
        public DateTime ReleaseDate { get {  return releaseDate; } set {  releaseDate = value; } }
        public DateTime ShowTime { get { return showTime; } set {  showTime = value; } }


        public Movie(string title, string runTime, List<string> genres, string producer, DateTime releaseDate, DateTime showTime)
        {
            Title = title;
            RunTime = runTime;
            Genres = genres;
            Producer = producer;
            ReleaseDate = releaseDate;
            ShowTime = showTime;
        }
    }
}
