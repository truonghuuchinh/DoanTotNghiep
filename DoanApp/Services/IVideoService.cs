﻿using DoanApp.Models;
using DoanData.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoanApp.Services
{
    public interface IVideoService
    {
        List<Video> GetAll();
        List<Video_vm> GetAllVideoPlayList(List<Video> video, AppUser user);
        Task<Video> Create(VideoRequest videoRequest,List<IFormFile> listPost);
        Task<int> Update(VideoRequest videoRequest);
        Task<int> Delete(int id);
        Task<Video> FinVideoAsync(int id);
        Task<int> UpdateLike(int idVideo,string reaction);
        Task<int> UpdateLikeReverse(int idVideo, string reaction);
        Task<int> UpdateView(int id);
        List<Video_vm> GetVideo_Vm(List<Video> lVideo, List<AppUser> lUser);
        Task<int> UpdateCategory(int id,int idCategory);
        Task<int> UpdatePermission(VideoRequest request);
        Task<int> DeleteVideoFavorite(int id);
        Task<int> UpdateStatus(int id);
     
        
    }
}
