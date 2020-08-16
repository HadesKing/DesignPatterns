using System;
using System.Collections.Generic;
using System.Text;
using Command.Receiver;

namespace Command.Commands
{
    public sealed class ConcreteCommand : BaseCommand
    {

        private IReceiver m_codeGroup = new CodeGroup();
        private IReceiver m_pageGroup = new PageGroup();
        private IReceiver m_requirementGroup = new RequirementGroup();

        public ConcreteCommand()
        {

        }

        public override void Excute()
        {
            m_codeGroup.ExcuteOpeation();
            m_pageGroup.ExcuteOpeation();
            m_requirementGroup.ExcuteOpeation();
        }

        public override void Rollback()
        {
            m_requirementGroup.Rollback();
            m_pageGroup.Rollback();
            m_codeGroup.Rollback();
        }
    }
}
