using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Domain.Features.UserAccounts;

namespace Workshop.Application.Features.UserAccounts {
    public interface IUserAccountRepository {
        Task<UserAccount?> GetByIdAsync(int id);
        Task<UserAccount> CreateAsync(UserAccount userAccount);
    }
}
