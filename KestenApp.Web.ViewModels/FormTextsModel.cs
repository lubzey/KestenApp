namespace KestenApp.Web.ViewModels
{
    public class FormTextsModel
    {
        public string AspAction { get; }
        public string AspActionRedirect { get; }
        public string SubmitButtonText { get; }
        public string PageTitle { get; }

        public FormTextsModel(string type, bool hasId = false)
        {
            if (hasId)
            {
                AspAction = "Edit";
                AspActionRedirect = "Details";
                SubmitButtonText = "Save";
                PageTitle = $"Edit {type}";                
            }
            else
            {
                AspAction = "Add";
                AspActionRedirect = "List";
                SubmitButtonText = "Create";
                PageTitle = $"Create {type}";
            }
        }
    }
}
