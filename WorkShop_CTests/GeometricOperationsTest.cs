using System.Diagnostics.CodeAnalysis;

namespace Workshop_C;

[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public class GeometricOperation
{
    // 1. Calculate the area of a circle given its radius
    public double CalculateCircleArea(double radius)
    {
        double areacir = Math.PI * radius * radius;
        return areacir;
    }

// 2. Calculate the circumference of a circle given its radius
    public double CalculateCircleCircumference(double radius)
    {
        double perimetrocir = 2 * Math.PI * radius ;
        return perimetrocir;
        
    }

// 3. Calculate the area of a rectangle given its width and height
    public double CalculateRectangleArea(double width, double height)
    {
        double rectangleArea = width * height;
        return rectangleArea;
    }

// 4. Calculate the perimeter of a rectangle given its width and height
    public double CalculateRectanglePerimeter(double width, double height)
    {
        double RectanglePerimeter = (2 * width) + (2 * height);
        return RectanglePerimeter;
    }

// 5. Calculate the area of a triangle given its base and height
    public double CalculateTriangleArea(double baseLength, double height)
    {
        double TriangleArea = (baseLength * height) / 2;
        return TriangleArea;
    }

// 6. Calculate the perimeter of a triangle given its three sides
    public double CalculateTrianglePerimeter(double side1, double side2, double side3)
    {
        double TrianglePerimeter = side1 + side2 + side3 ;
        return TrianglePerimeter;
    }

// 7. Calculate the area of a square given its side length
    public double CalculateSquareArea(double side)
    {
        double SquareArea = side * side;
        return SquareArea;
    }

// 8. Calculate the perimeter of a square given its side length
    public double CalculateSquarePerimeter(double side)
    {
        double SquarePerimeter = side * 4;
        return SquarePerimeter;
    }

// 9. Calculate the length of the hypotenuse of a right triangle given the other two sides
    public double CalculateHypotenuse(double sideA, double sideB)
    {
        if (sideA == 0 || sideB == 0)
        {
            return 0;
        }
        double Hypotenuse = (Math.Sqrt((sideA * sideA) + (sideB * sideB)));
        return Hypotenuse;
    }

// 10. Calculate the area of a trapezoid given its bases and height
    public double CalculateTrapezoidArea(double base1, double base2, double height)
    {
        double TrapezoidArea = ((base1 + base2) * height) / 2;
        return TrapezoidArea;
    }

// 11. Calculate the volume of a cylinder given its radius and height
    public double CalculateCylinderVolume(double radius, double height)
    {
        double CylinderVolume = Math.PI * height * (radius * radius);
        return CylinderVolume;
    }

// 12. Calculate the volume of a cube given its side length
    public double CalculateCubeVolume(double side)
    {
        double CubeVolume = side * side * side;
        return CubeVolume;
    }

// 13. Calculate the volume of a sphere given its radius
    public double CalculateSphereVolume(double radius)
    {
        double SphereVolume = (4 * Math.PI * (radius * radius * radius)) / 3;
        return SphereVolume;
    }

// 14. Calculate the surface area of a cylinder given its radius and height
    public double CalculateCylinderSurfaceArea(double radius, double height)
    {
       double CylinderSurfaceArea = (2 * Math.PI * radius) * (radius + height) ;
       return CylinderSurfaceArea;
    }

// 15. Calculate the surface area of a cube given its side length
    public double CalculateCubeSurfaceArea(double side)
    {
        double CubeSurfaceArea = 6 * (side * side);
        return CubeSurfaceArea;
    }

// 16. Calculate the surface area of a sphere given its radius
    public double CalculateSphereSurfaceArea(double radius)
    {
        double SphereSurfaceArea = 4 * Math.PI * radius * radius ;
        return SphereSurfaceArea;
    }

// 17. Calculate the volume of a cone given its radius and height
    public double CalculateConeVolume(double radius, double height)
    {
        double ConeVolume = (Math.PI * radius * radius * height ) / 3;
        return ConeVolume;
    }

// 18. Calculate the volume of a pyramid given its base and height
    public double CalculatePyramidVolume(double baseArea, double height)
    {
        double PyramidVolume = (baseArea * height ) / 3;
        return PyramidVolume;
    }

// 19. Calculate the area of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonArea(int numSides, double sideLength)
    {
        if (numSides == 0)
        {
            return 0.0;
        }
        double RegularPolygonArea = (numSides * (sideLength * sideLength)) / (4 * (Math.Tan(Math.PI / numSides)));
        return RegularPolygonArea;
    }

// 20. Calculate the perimeter of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonPerimeter(int numSides, double sideLength)
    {
        double PolygonPerimeter = (numSides * sideLength);
        return PolygonPerimeter;
    }

// 21. Check if three sides can form a triangle
    public bool CanFormTriangle(double side1, double side2, double side3)
    {
        if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
        {
            return true;
        }
        return false;
    }
      

// 22. Calculate the area of a parallelogram given its base and height
    public double CalculateParallelogramArea(double baseLength, double height)
    {
        double ParallelogramArea = baseLength * height;
        return ParallelogramArea;
    }

// 23. Calculate the perimeter of a parallelogram given its base and sides
    public double CalculateParallelogramPerimeter(double baseLength, double sideLength)
    {
        double ParallelogramPerimeter = 2 * (baseLength + sideLength);
        return ParallelogramPerimeter;
    }

// 24. Check if four sides can form a rectangle
    public bool CanFormRectangle(double side1, double side2, double side3, double side4)
    {
        if (side1 == side3 && side2 == side4)
        {
            return true;
        }
        return false;
    }

// 25. Calculate the diagonal of a rectangle given its width and height
    public double CalculateRectangleDiagonal(double width, double height)
    {
        double RectangleDiagonal = (Math.Sqrt((width * width) + (height * height)));
        return RectangleDiagonal;
    }

// 26. Check if a set of points form a right triangle
    public bool IsRightTriangle(double sideA, double sideB, double hypotenuse)
    {
        if ((hypotenuse * hypotenuse) == (sideA * sideA + sideB * sideB))
        {
            return true;
        }
        
        return false;
    }

// 27. Calculate the area of an ellipse given its major and minor axes
    public double CalculateEllipseArea(double majorAxis, double minorAxis)
    {
       return Math.PI * majorAxis * minorAxis;;
    }

// 28. Check if three angles can form a triangle (sum of angles must be 180 degrees)
    public bool CanFormTriangleFromAngles(double angle1, double angle2, double angle3)
    {
        if (angle1 == 0 || angle2 == 0 || angle3 == 0)
        {
            return false;
        }
        double TriangleFromAngles = angle1 + angle2 + angle3;

        if (TriangleFromAngles != 180)
        {
            return false;
        }
        return true;

    }

// 29. Calculate the surface area of a cone given its radius and slant height
    public double CalculateConeSurfaceArea(double radius, double slantHeight)
    {
        double ConeSurfaceArea = Math.PI * radius * (radius + slantHeight);
        return ConeSurfaceArea;
    }

// 30. Calculate the perimeter of an ellipse given its major and minor axes
    public double CalculateEllipsePerimeter(double majorAxis, double minorAxis)
    {
        if (minorAxis == 0)
        {
            return 0.0;
        }
        double perimeter = 2 * Math.PI * Math.Sqrt(((majorAxis * majorAxis) + (minorAxis * minorAxis)) / 2);
        return perimeter;
    }

// 31. Use the Law of Cosines to find the third side given two sides and the included angle
    public double CalculateThirdSideLawOfCosines(double sideA, double sideB, double angleDegrees)
    {
        if (sideA == 0 || sideB == 0)
        {
            return 0.0;
        }
        // Math.Cos solo funciona en radianes
        angleDegrees = (angleDegrees * Math.PI) / 180;
        double ThirdSide = Math.Sqrt((sideA * sideA) + (sideB * sideB) - (2 * sideA * sideB * Math.Cos(angleDegrees)));
        return ThirdSide;
    }

// 32. Use the Law of Cosines to find an angle given three sides of a triangle
    public double CalculateAngleLawOfCosines(double sideA, double sideB, double sideC)
    {
        double cosAngle = ((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC));
        double angle = Math.Acos(cosAngle);
        return angle;
    }

// 33. Use the Law of Sines to find a side given an angle and its opposite side
    public double CalculateSideLawOfSines(double angleA, double sideA, double angleB)
    {

        if (sideA == 0)
        {
            return Double.NaN;
        }
        angleA = (angleA * Math.PI) / 180;
        angleB = (angleB * Math.PI) / 180;

        double SideB = (sideA * Math.Sin(angleB)) / Math.Sin(angleA) ;
        return SideB;
    }

// 34. Use the Law of Sines to find an angle given two angles and one side
    public double CalculateAngleLawOfSines(double angleA, double angleB, double sideC)
    {
        if (angleA == 0 || angleB == 0 || sideC == 0)
        {
            return 0.0;
        }
        
        double angleC = 180 - (angleA + angleB);
        return angleC ;
    }

// 35. Find the area of a triangle given two sides and the included angle using the Law of Cosines
    public double CalculateTriangleAreaWithCosine(double sideA, double sideB, double angleDegrees)
    {
        double angleRadians = angleDegrees * (Math.PI / 180); // Convertir el ángulo a radianes
        double area = 0.5 * sideA * sideB * Math.Sin(angleRadians); // Calcular el área
        return area;
 
    }

// 36. Check if three sides can form a triangle using the Law of Cosines
    public bool CanFormTriangleWithCosines(double sideA, double sideB, double sideC)
    {
        // Desigualdad triangular
        bool satisfiesTriangleInequality = 
            (sideA + sideB > sideC) &&
            (sideA + sideC > sideB) &&
            (sideB + sideC > sideA);
        
        return satisfiesTriangleInequality;
 
    }

// 37. Calculate the perimeter of a triangle using the Law of Cosines
    public double CalculateTrianglePerimeterWithCosines(double sideA, double sideB, double sideC)
    {
        if (sideA == 0 || sideB == 0 || sideC == 0)
        {
            return 0.0;
        }
        double trianglePerimeter = sideA + sideB + sideC;
        return trianglePerimeter;
        
    }

// 38. Calculate the height of a triangle using the Law of Cosines
    public double CalculateTriangleHeightWithCosines(double sideA, double angleDegrees)
    {
        double angleRadians = angleDegrees * (Math.PI / 180); 
        double height = sideA * Math.Sin(angleRadians);  
        return height;
 
    }

// 39. Check if an angle is a right angle using the Law of Cosines
    public bool IsRightAngleWithCosines(double sideA, double sideB, double sideC)
    {
        double hypotenuse = Math.Max(sideA, Math.Max(sideB, sideC));
        
        return Math.Pow(hypotenuse,2) == (Math.Pow(sideA,2) + Math.Pow(sideB,2));
    }

// 40. Calculate the area of a triangle given two sides and the included angle using the Law of Sines
    public double CalculateTriangleAreaWithSines(double angleA, double sideA, double sideB)
    {
        double angleARadians = angleA * (Math.PI / 180);
        
        double area = 0.5 * sideA * sideB * Math.Sin(angleARadians);

        return area;

    }
