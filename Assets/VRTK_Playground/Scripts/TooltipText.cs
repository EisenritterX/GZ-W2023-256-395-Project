using Tilia.Visuals.Tooltip;
using UnityEngine;
using Zinnia.Utility;

public class TooltipText : MonoBehaviour
{
    public TooltipFacade toolTipFacade;

    public void ShowToolTip(float val)
    {
        //toolTipFacade.TooltipText = string.Concat("Slider Value : ", val);
        toolTipFacade.TooltipText = val.ToString("f0");
    }

    public void ShowToolTip(GameObject go) //By declaring the methods parameter as a game object, this method will show up as a dynamic method, when used as part of events of a facade component. 
    {
        toolTipFacade.TooltipText = go.tag;
    }

    public void ClearToolTip()
    {
        toolTipFacade.TooltipText = string.Empty;
    }

}
