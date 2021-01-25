using Domain.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITokenService _tokenService;
        public UserService(IUserRepository repository, IUnitOfWork unitOfWork, ITokenService tokenService)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
        }
        public bool SaveUser(UserRequest request)
        {
            _repository.SaveUser(new User(request.Login, request.Password, request.CreationDate, request.Role));

            return _unitOfWork.Commit();
        }

        public UserLogin Login(UserLogin request)
        {
            var user = _repository.GetByLogin(request);

            if (user is null)
                return null;

            request.InsertToken(_tokenService.GenerateToken(user));

            return request;
        }

        public IEnumerable<User> GetUsers(int? id)
        {
            return _repository.Get(id);
        }
    }
}
