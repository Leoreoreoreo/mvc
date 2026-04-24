namespace MVC;

public class AuthorService
{
    readonly AuthorModel _AuthorModel;
    public AuthorService(AuthorModel authorModel)
    {
        _AuthorModel = authorModel;
    }
    public List<Authors> GetAllAuthors()
    {
       return _AuthorModel.GetAllAuthors();
    }
}
