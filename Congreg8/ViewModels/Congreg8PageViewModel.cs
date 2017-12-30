using System;
using System.Collections.Generic;
using Congreg8.Core.Services;
using Congreg8.Models;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace Congreg8.Core.ViewModels 
{
    public class Congreg8PageViewModel : MvxViewModel
    {
        readonly ITokenService tokenService;
        readonly IFriendsService friendsService;

        private List<UserTaggableFriend> friendOptions;
        public List<UserTaggableFriend> FriendOptions
        {
            get { return friendOptions; }
            set { SetProperty(ref friendOptions, value); }
        }

        private int carouselPosition;
        public int CarouselPosition
        {
            get { return carouselPosition; }
            set { SetProperty(ref carouselPosition, value); }
        }

        public Congreg8PageViewModel(ITokenService tokenService, IFriendsService friendsService)
        {
            this.friendsService = friendsService;
            this.tokenService = tokenService;

            var userId = tokenService.GetCurrentToken().UserId;
            var token = tokenService.GetCurrentToken().TokenString;

            var friends = friendsService.GetUserFriends(userId, token);

            CarouselPosition = 0;
            FriendOptions = new List<UserTaggableFriend>();

            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                FriendOptions.Add(friends[rand.Next(0, friends.Count - 1)]);
            }
        }
    }
}

