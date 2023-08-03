﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface IAccountRepository
    {
        public void CreateAccount(string CPF);
        public void ChangeBalance(int value, int numberAccount);
    }
}