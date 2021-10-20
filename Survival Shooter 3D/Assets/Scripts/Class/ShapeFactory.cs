using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFactory 
{
   //use getShape method to get object of type shape 
   public Shape getShape(string shapeType){
      if(shapeType == null){
         return null;
      }		
      if(shapeType.Equals("CIRCLE")){
         return new Circle();
         
      } else if(shapeType.Equals("RECTANGLE")){
         return new Rectangle();
         
      } else if(shapeType.Equals("SQUARE")){
         return new Square();
      }
      
      return null;
   }
}
