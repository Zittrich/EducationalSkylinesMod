using ICities;

namespace EducationalSkylinesMod
{
    public class Identity : IUserMod
    {
        public string Name
        {
            get { return "Educational Skylines"; }
        }

        public string Description
        {
            get { return "Turns Cities: Skylines into an educational Mod"; }
        }
    }
}
