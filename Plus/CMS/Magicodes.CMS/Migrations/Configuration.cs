
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Magicodes.CMS.Models;

namespace Magicodes.CMS.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CMSDbContext>
    {
        public Configuration()
        {
            //�ر��Զ�����Ǩ�ƣ��ó���ֻ�������Լ����ɵ�Ǩ�ƣ�
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CMSDbContext context)
        {
            
        }
    }
}
