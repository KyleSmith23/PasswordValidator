// C# Player's guide challenges - The Password Validator
PasswordValidator password = new PasswordValidator();
bool validPassword = false;

while (!validPassword)
{
     Console.WriteLine("Create a Password");
    string newPassword = Console.ReadLine();
    bool valid = password.IsValid(newPassword);

    if (valid){
        Console.WriteLine("Valid");
        validPassword = true;
    }
    else { Console.WriteLine("Invalid - Try again"); }

}

// Class 
public class PasswordValidator
{
    
    public bool IsValid(string password)
    {   
        if (password.Length < 6) {  return false; }
        if (password.Length > 13) { return false; }

        int capitalLetter = 0;
        int lowerLetter = 0;
        int digits =0;
        int invalidChar = 0;

        foreach (char letter in password) {

           if (char.IsUpper(letter)){ capitalLetter++;}
           if (char.IsLower(letter)){ lowerLetter++; }
           if (char.IsDigit(letter)){ digits++; }
           if ( letter == 'T' || letter == '&') { invalidChar++; } 

         }

        if (invalidChar != 0) { return false; }
        if (capitalLetter != 0 && lowerLetter !=0 && digits != 0) { return true; }
        return false;
    }
}