public class Artisan
{
    private string _name;
    private string _craftType; 
    private int _yearsExperience;
    private string _district;

    // Setters with validation (encapsulation!!!!!!!)
    public void SetName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            _name = name;
        }
    }

    public void SetCraftType(string craftType)
    {
        if (!string.IsNullOrWhiteSpace(craftType))
        {
            _craftType = craftType;
        }
    }

    public void SetYearsExperience(int years)
    {
        if (years >= 0)
        {
            _yearsExperience = years;
        }
    }

    public void SetDistrict(string district)
    {
        if (!string.IsNullOrWhiteSpace(district))
        {
            _district = district;
        }
    }

    public string GetSummary()
    {
        return $"{_name} - {_craftType}, {_yearsExperience} years experience, from {_district}.";
    }
}
