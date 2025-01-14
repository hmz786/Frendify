﻿using CircleApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CircleApp.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IPostsService _postsService;
        public FavoritesController(IPostsService postsService)
        {
            _postsService = postsService;
        }


        public async Task<IActionResult> Index()
        {
            int loggedInUserId = 1;
            var myFavoritePosts = await _postsService.GetAllFavoritedPostsAsync(loggedInUserId);

            return View(myFavoritePosts);
        }
    }
}