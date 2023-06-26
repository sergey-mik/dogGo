﻿using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetWalkByWalker(int walkerId);
        List<Walker> GetWalkersInNeighborhood(int neighborhoodId);
    }
}
