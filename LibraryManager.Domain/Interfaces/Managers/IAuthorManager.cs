﻿namespace LibraryManager.Domain
{
    public interface IAuthorManager
    {
        List<AuthorDto> GetAll();
        bool Add(AuthorDto authorDto);
        bool Delete(int authorId);
    }
}
