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
            var selectedNumbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                var number = rand.Next(0, friends.Count - 1);
                while(selectedNumbers.Contains(number)){
                     number = rand.Next(0, friends.Count - 1);
                }
                selectedNumbers.Add(number);
                FriendOptions.Add(friends[number]);
            }
        }
    }
}

