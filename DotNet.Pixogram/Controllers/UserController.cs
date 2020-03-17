using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pixogram.BusinessLayer.Interfaces;
using Pixogram.BusinessLayer.Services;
using Pixogram.DataLayer;
using Pixogram.Models;

namespace DotNet.Pixogram.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserServices _service;


        public UserController()
        {
           //Create object for services
        }


        public IActionResult Index()
        {
            return View();
        }


        public bool AddComment(Feedback Feedback)
        {
            return true;
        }

        public bool AddContent(List<Content> content, int UserID)
        {
            return true;
        }

        public bool DeleteProfile(int Id)
        {
            return true;
        }

        public IActionResult FollowList(int UserId)
        {
            return View();
        }

        public bool FollowUser(int UserId, int SenderId)
        {
            return true;
        }

        public IActionResult GetContent(int Id)
        {
            return View();
        }

        public IActionResult GetProfile(int Id)
        {
            return View();
        }

        public bool HideMedia(string picturePath, bool Visibility, string VideoPath)
        {
            return true;
        }

        public bool Login(string UserName, string Password)
        {
            return true;

        }

        public IActionResult OrganizeImage(int UserId, List<Content> Content)
        {
            return View();
        }

        public IActionResult OrganizeVideo(int UserId, List<Content> Content)
        {
            return View();
        }

        public bool Register(User user)
        {
            return true;
        }

        public bool ResetPassword(string Password)
        {
            return true;
        }

        public bool UpdateContent(int UserId, Content Content)
        {
            return true;
        }

        public bool UpdateProfile(User User)
        {
            return true;
        }

        public IActionResult ActivityLog(int UserId)
        {
            return View();
        }

        public IActionResult GetUserById(int UserId)
        {
            return View();

        }
        public IActionResult GetContentByUserId(int UserId)
        {
            return View();
        }


    }
}