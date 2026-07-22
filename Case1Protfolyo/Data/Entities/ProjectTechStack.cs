namespace Portfolio.Data.Entities
{
    public class ProjectTechStack
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        //navigation property
        public Project Project { get; set; }
        public int TechStackId { get; set; }
        //navigation property
        public TechStack TechStack { get; set; }
    }
}
