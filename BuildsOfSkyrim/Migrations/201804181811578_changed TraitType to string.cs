namespace BuildsOfSkyrim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedTraitTypetostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CharacterTraits", "TraitType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CharacterTraits", "TraitType", c => c.Int(nullable: false));
        }
    }
}
