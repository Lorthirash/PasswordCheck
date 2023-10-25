namespace PasswordCheckDemo
{
    internal interface IPasswordValidator
    {
        bool IsStrongPassword(string password);
    }
}