//***********************************************************************
// Assembly         : LatestMediaHandler
// Author           : cul8er
// Created          : 05-09-2010
//
// Last Modified By : ajs
// Last Modified On : 24-09-2015
// Description      : 
//
// Copyright        : Open Source software licensed under the GNU/GPL agreement.
//***********************************************************************

using System;
using System.Globalization;

namespace LatestMediaHandler
{
  internal class Latest
  {
    private string dateAdded;
    private string thumb;
    private string fanart;
    private string title;
    private string subtitle;
    private string artist;
    private string album;
    private string genre;
    private string rating;
    private string roundedRating;
    private string classification;
    private string runtime;
    private string year;
    private string seriesIndex;
    private string seasonIndex;
    private string episodeIndex;
    private string thumbSeries;
    private object playable;
    //string fanart1;        
    //string fanart2;
    private string directory;
    private string id;
    private string summary;
    private bool isnew;
    private string banner;
    private string clearart;
    private string clearlogo;
    private string cd;
    private string dateWatched;
    private string userrating;
    private string animatedPoster;
    private string animatedBackground;

    internal string Summary
    {
      get { return summary; }
      set { summary = value; }
    }

    internal string Id
    {
      get { return id; }
      set { id = value; }
    }

    internal object Playable
    {
      get { return playable; }
      set { playable = value; }
    }

    internal string ThumbSeries
    {
      get { return thumbSeries; }
      set { thumbSeries = value; }
    }

    internal string DateAdded
    {
      get { return dateAdded; }
      set { dateAdded = value; }
    }

    internal string Thumb
    {
      get { return thumb; }
      set { thumb = value; }
    }

    internal string Fanart
    {
      get { return fanart; }
      set { fanart = value; }
    }

    internal string Title
    {
      get { return title; }
      set { title = value; }
    }

    internal string Subtitle
    {
      get { return subtitle; }
      set { subtitle = value; }
    }

    internal string Artist
    {
      get { return artist; }
      set { artist = value; }
    }

    internal string Album
    {
      get { return album; }
      set { album = value; }
    }

    internal string Genre
    {
      get { return genre; }
      set { genre = value; }
    }

    internal string Rating
    {
      get { return rating; }
      set { rating = value; }
    }

    internal double DoubleRating
    {
      get
      {
        double r = 0.0;
        if (!string.IsNullOrEmpty(rating))
        {
          if (!Double.TryParse(rating, out r))
          {
            Double.TryParse(rating.Replace(".", ","), out r);
          }
        }
        return r;
      }
      set { rating = value.ToString(CultureInfo.CurrentCulture); }
    }

    internal string RoundedRating
    {
      get { return roundedRating; }
      set { roundedRating = value; }
    }

    internal string Classification
    {
      get { return classification; }
      set { classification = value; }
    }

    internal string Runtime
    {
      get { return runtime; }
      set { runtime = value; }
    }

    internal string Year
    {
      get { return year; }
      set { year = value; }
    }

    internal string DateWatched
    {
      get { return dateWatched; }
      set { dateWatched = value; }
    }

    internal string UserRating
    {
      get { return userrating; }
      set { userrating = value; }
    }

    internal string SeriesIndex
    {
      get { return seriesIndex; }
      set { seriesIndex = value; }
    }

    internal string SeasonIndex
    {
      get { return seasonIndex; }
      set { seasonIndex = value; }
    }

    internal string EpisodeIndex
    {
      get { return episodeIndex; }
      set { episodeIndex = value; }
    }

    internal string Banner
    {
      get { return banner; }
      set { banner = value; }
    }

    internal string ClearArt
    {
      get { return clearart; }
      set { clearart = value; }
    }

    internal string ClearLogo
    {
      get { return clearlogo; }
      set { clearlogo = value; }
    }

    internal string AnimatedPoster
    {
      get { return animatedPoster; }
      set { animatedPoster = value; }
    }

    internal string AnimatedBackground
    {
      get { return animatedBackground; }
      set { animatedBackground = value; }
    }

    internal string CD
    {
      get { return cd; }
      set { cd = value; }
    }
    
    internal string Plot
    {
      get { return (string.IsNullOrEmpty(summary) ? Translation.NoDescription : summary); }
    }

    internal string PlotOutline
    {
      get { return Utils.GetSentences(Plot, Utils.LatestPlotOutlineSentencesNum); }
    }

    internal string MoviePlotOutline
    {
      get
      {
        if (string.IsNullOrWhiteSpace(Subtitle))
        {
          return Utils.GetSentences(Plot, Utils.LatestPlotOutlineSentencesNum);
        }
        return Subtitle;
      }
    }

    internal string Directory
    {
      get { return directory; }
      set { directory = value; }
    }

    internal string New
    {
      get { return (isnew ? "true" : "false"); }
      set { isnew = value.ToLower().Equals("true"); }
    }

    internal bool IsNew
    {
      get { return isnew; }
      set { isnew = value; }
    }

    internal Latest(string dateAdded, 
                    string thumb, string fanart, 
                    string title, string subtitle, 
                    string artist, string album, string genre, 
                    string rating, string roundedRating, string classification, string runtime, string year, 
                    string seasonIndex, string episodeIndex, 
                    string thumbSeries, object playable, string id, string summary, 
                    string seriesIndex, bool isnew = false)
    {
      this.dateAdded = dateAdded;
      if (!string.IsNullOrEmpty(thumb))
      {
        this.thumb = thumb.Replace("/", @"\");
      }
      else
      {
        this.thumb = thumb;
      }
      if (!string.IsNullOrEmpty(fanart))
      {
        this.fanart = fanart.Replace("/", @"\");
      }
      else
      {
        this.fanart = fanart;
      }
      if (!string.IsNullOrEmpty(thumbSeries))
      {
        this.thumbSeries = thumbSeries.Replace("/", @"\");
      }
      else
      {
        this.thumbSeries = thumbSeries;
      }
      this.title = title;
      this.subtitle = subtitle;
      this.artist = artist;
      this.album = album;
      if (!string.IsNullOrEmpty(genre))
      {
        this.genre = genre.Replace("|", ",").Replace("/", ",");
      }
      else
      {
        this.genre = genre;
      }
      this.rating = rating;
      this.roundedRating = roundedRating;
      this.classification = classification;
      this.runtime = runtime;
      this.year = year;
      this.seriesIndex = seriesIndex;
      this.seasonIndex = seasonIndex;
      this.episodeIndex = episodeIndex;
      this.playable = playable;
      this.id = id;
      this.summary = summary;
      this.isnew = isnew;
    }

    internal Latest(string dateAdded, 
                    string thumb, string fanart, 
                    string title, string subtitle, 
                    string artist, string album, string genre, 
                    string rating, string roundedRating, string classification, string runtime, string year, 
                    string seasonIndex, string episodeIndex, 
                    string thumbSeries, object playable, string id, string summary, 
                    string seriesIndex, 
                    string directory,
                    bool isnew = false)
             : this(dateAdded, 
                    thumb, fanart, 
                    title, subtitle, 
                    artist, album, genre, 
                    rating, roundedRating, classification, runtime, year, 
                    seasonIndex, episodeIndex, 
                    thumbSeries, playable, id, summary, 
                    seriesIndex, isnew)
    {
      this.directory = directory;
    }

    internal Latest(string dateAdded, 
                    string thumb, string fanart, 
                    string title, string subtitle, 
                    string artist, string album, string genre, 
                    string rating, string roundedRating, string classification, string runtime, string year, 
                    string seasonIndex, string episodeIndex, 
                    string thumbSeries, object playable, string id, string summary, 
                    string seriesIndex, 
                    string banner, string clearart, string clearlogo, string cd,
                    bool isnew = false)
             : this(dateAdded, 
                    thumb, fanart, 
                    title, subtitle, 
                    artist, album, genre, 
                    rating, roundedRating, classification, runtime, year, 
                    seasonIndex, episodeIndex, 
                    thumbSeries, playable, id, summary, 
                    seriesIndex, isnew)
    {
      this.banner = banner;
      this.clearart = clearart;
      this.clearlogo = clearlogo;
      this.cd = cd;
    }

    internal Latest(string dateAdded,
                    string thumb, string fanart,
                    string title, string subtitle,
                    string artist, string album, string genre,
                    string rating, string roundedRating, string classification, string runtime, string year,
                    string seasonIndex, string episodeIndex,
                    string thumbSeries, object playable, string id, string summary,
                    string seriesIndex,
                    string banner, string clearart, string clearlogo, string cd,
                    string aposter, string abackground,
                    bool isnew = false)
             : this(dateAdded,
                    thumb, fanart,
                    title, subtitle,
                    artist, album, genre,
                    rating, roundedRating, classification, runtime, year,
                    seasonIndex, episodeIndex,
                    thumbSeries, playable, id, summary, seriesIndex, 
                    banner, clearart, clearlogo, cd, 
                    isnew)
    {
      this.animatedPoster = aposter;
      this.animatedBackground = abackground;
    }

    internal Latest(string dateAdded, string dateWatched,
                    string thumb, string fanart,
                    string title, string subtitle,
                    string artist, string album, string genre,
                    string rating, string roundedRating, string classification, string runtime, string year,
                    string seasonIndex, string episodeIndex,
                    string thumbSeries, object playable, string id, string summary,
                    string seriesIndex,
                    string banner, string clearart, string clearlogo, string cd,
                    string aposter, string abackground,
                    bool isnew = false)
             : this(dateAdded,
                    thumb, fanart,
                    title, subtitle,
                    artist, album, genre,
                    rating, roundedRating, classification, runtime, year,
                    seasonIndex, episodeIndex,
                    thumbSeries, playable, id, summary, seriesIndex,
                    banner, clearart, clearlogo, cd,
                    aposter, abackground,
                    isnew)
    {
      this.dateWatched = dateWatched;
    }
  }
}
