using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;

namespace IMAGE_EDITOR_V2
{
    public class Resize_image : Adorner
    {
        Thumb topLeft,  bottomRight;
        VisualCollection visuals;
        //Implement Constructor
        public Resize_image(UIElement adornedElement) : base(adornedElement)
        {
            visuals = new VisualCollection(this);
            
            bottomRight = new Thumb() { Background = Brushes.Green, Width = 10, Height = 10 };

            //Subscribe to and event thaths defined on the Thumb class,when we drag in records the change of draging
            
            bottomRight.DragDelta += BottomRight_DragDelta;

          
            visuals.Add(bottomRight);
        }
        //event handler for the DragDelta event of a BottomRight object.
        //The code resizes the AdornedElement object by increasing or decreasing
        //its height and width based on the vertical and horizontal change of the drag operation represented by the DragDeltaEventArgs object.
        //If the height or width becomes less than 0, it is set to 0 to prevent the element from having negative dimensions.
        private void BottomRight_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var element1 = (FrameworkElement)AdornedElement;
            
            element1.Height = element1.Height + e.VerticalChange < 0 ? 0 : element1.Height + e.VerticalChange;
            element1.Width = element1.Width + e.HorizontalChange < 0 ? 0 : element1.Width + e.HorizontalChange;
        }


        //GetVisualChild method returns the visual child of the control at the specified index from a list of visual children stored in the visuals field
        protected override Visual GetVisualChild(int index)
        {
            return visuals[index];
        }
        //The VisualChildrenCount property returns the number of visual children of the control. 
        protected override int VisualChildrenCount
        {
            get { return visuals.Count; }
        }

        //The ArrangeOverride method arranges the child elements of the control in a specific layout.
        //In this case, the code arranges a bottomRight element at the bottom-right corner of the
        //AdornedElement (presumably the control being adorned) with a size of 10x10 pixels. The finalSize
        //parameter specifies the final size allocated for the control by its parent container.
        //The ArrangeOverride method returns the final size of the control. 
        protected override Size ArrangeOverride(Size finalSize)
        {
            
            bottomRight.Arrange(new Rect(AdornedElement.DesiredSize.Width-1, AdornedElement.DesiredSize.Height-1, 10, 10));
            return finalSize;
        }
    }


}
