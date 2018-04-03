﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetBdEntity;

namespace ToLetBdInterface
{
    public interface IPostImageRepository
    {
        List<PostImage> GetAll();
        PostImage Get(int id);
        int Insert(PostImage image);
        int Update(PostImage image);
        int Delete(int id);
    }
}
