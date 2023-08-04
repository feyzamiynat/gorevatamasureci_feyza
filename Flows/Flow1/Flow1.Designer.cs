using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace gorevatamasureci_feyza.Flows
{
    [WorkflowIdentifier("ba66ce53-a8ba-49af-970e-c71f12acdd93")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _position1;
		private FlowPosition _position2;
		private FlowAssign _assignment1;
		private FlowCompare _compare1;
		private Variable _variable1;
		private Variable _variable2;
		private FlowDocument _document1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition Position1 => _position1 ??= new FlowPosition("Position1", _workflowData, this);
		private FlowPosition Position2 => _position2 ??= new FlowPosition("Position2", _workflowData, this);
		private FlowAssign Assignment1 => _assignment1 ??= new FlowAssign("Assignment1", _workflowData, this);
		private FlowCompare Compare1 => _compare1 ??= new FlowCompare("Compare1", _workflowData, this);
		private Variable Variable1 => _variable1 ??= new Variable("Variable1", _workflowData, this);
		private Variable Variable2 => _variable2 ??= new Variable("Variable2", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);


        #endregion

        #region [ctor]        

        public Flow1() : this(null)
        {
            
        }
        
        public Flow1(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}