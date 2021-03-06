﻿using Plus.Domain.Entities;

namespace MeowvBlog.Core.Domain.Blog
{
    public class FriendLink : Entity
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string LinkUrl { get; set; }
    }
}