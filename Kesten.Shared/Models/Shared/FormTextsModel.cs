namespace Kesten.Shared.Models.Shared
{
    public class FormTextsModel
    {
        public string SubmitAction { get; }
        public string BackToAction { get; }
        public string SubmitButtonValue { get; }
        public string PageTitle { get; }

        public FormTextsModel(string type, bool hasId = false)
        {
            if (hasId)
            {
                SubmitAction = "Edit";
                BackToAction = "Details";
                SubmitButtonValue = "Save";
                PageTitle = $"Edit {type}";
            }
            else
            {
                SubmitAction = "Add";
                BackToAction = "List";
                SubmitButtonValue = "Create";
                PageTitle = $"Create {type}";
            }
        }
    }
}
