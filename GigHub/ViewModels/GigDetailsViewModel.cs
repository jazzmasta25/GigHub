﻿using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigDetailsViewModel
    {
        public Gig Gig { get; set; }
        public bool IsGoing { get; set; }
        public bool ShowActions { get; set; }
        public bool IsFollowing { get; set; }
    }
}