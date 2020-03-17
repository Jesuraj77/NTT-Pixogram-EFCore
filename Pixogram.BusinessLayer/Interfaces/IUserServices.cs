using Pixogram.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        bool Index();
        bool Register(User user);
        bool Login(string UserName, string Password);
        bool ResetPassword(string Password);
        User GetProfile(int Id);
        bool UpdateProfile(User User);
        bool DeleteProfile(int Id);
        bool AddContent(List<Content> content, int UserID);
        List<Content> OrganizeImage(int UserId, List<Content> Content);
        List<Content> OrganizeVideo(int UserId, List<Content> Content);
        Content GetContent(int Id);
        bool UpdateContent(int UserId, Content Content);
        bool AddComment(Feedback Feedback);
        bool FollowUser(int UserId, int SenderId);
        List<Follow> FollowList(int UserId);
        bool HideMedia(string picturePath, bool Visibility, string VideoPath);
        List<ILog> ActivityLog(int UserId);
        User GetUserById(int UserId);
        List<Content> GetContentByUserId(int UserId);

    }
}
