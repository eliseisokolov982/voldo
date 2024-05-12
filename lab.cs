try
{
    // Proxy check logic goes here
}
catch (Exception e)
{
    // Log the error message with more details
    Console.WriteLine($"Error during proxy check at {DateTime.Now}: {e.Message}");

    // It's often helpful to log the stack trace for debugging purposes
    Console.WriteLine(e.StackTrace);

    // Optionally, rethrow the exception if you want it to be handled further up the call stack
    // throw;
}
