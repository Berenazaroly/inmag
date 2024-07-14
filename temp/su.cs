public IActionResult YourActionMethod()
{
    try
    {
        // Some operation that might throw an exception
        // Example:
        throw new Exception("An error occurred.");
    }
    catch (Exception e)
    {
        // Returning a bad request with an error message
        return BadRequest(new { message = e.Message });
    }
}
