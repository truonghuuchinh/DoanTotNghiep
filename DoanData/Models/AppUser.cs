﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoanData.Models
{

    public class AppUser:IdentityUser<int>
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string LastLogin { get; set; }
        public bool LoginExternal { get; set; }
        public string ImgChannel { get; set; }
        public string Avartar { get; set; }
        public string CreateDate { get; set; }
        public string DescriptionChannel { get; set; }
        public bool Status { get; set; } = true;
        public List<Video> Videos { get; set; }
        public List<Comment> Comments { get; set; }
        public List<PlayList> PlayLists { get; set; }
        public List<FollowChannel> FromUsers { get; set; }
        public List<FollowChannel> ToUsers { get; set; }
        public List<LikeVideoDetail> LikeVideoDetails { get; set; }
        public List<ListVideoFavavorite> ListVideoFavavorites { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<Notification> FromNotifications { get; set; }
        public List<ReportVideo> ReportVideos { get; set; }
        public List<LikeCommentDetail> LikeComments { get; set; }
        public List<VideoWatched> VideoWatcheds { get; set; }
    }
}
