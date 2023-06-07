# ProjectDsp
### ProjectDsp is a Windows Forms application that performs the Continuous Fourier transform on an input image and visualizes the transformed signal using a chart. It utilizes the MathNet.Numerics library for mathematical computations and the System.Windows.Forms.DataVisualization.Charting library for charting capabilities.

![photo_2023-06-07_17-21-54](https://github.com/SamaIbrahimRamadan/ProjectDsp/assets/126702812/9f53a43c-7581-47ad-b53f-dcb181f11003)


## Features
- Upload Image: The application allows users to upload an image file (in BMP, JPG, JPEG, PNG, or GIF format) for processing.

- Continuous Fourier transform: After selecting an image, users can click the "Continuous Fourier transform" button to perform the Continuous Fourier transform on the image. 

- Chart Visualization: The transformed signal is visualized using a line chart. The x-axis represents the index of each frequency component, and the y-axis represents the magnitude of the transformed signal.

- Chart Customization: The chart display can be customized by adjusting the range of the x-axis and y-axis. The minimum and maximum values of both axes can be set to focus on specific frequency ranges.

## Technologies Used
- C#: The application is developed using the C# programming language.

- .NET Framework: It utilizes the .NET Framework for Windows Forms development.

- MathNet.Numerics: The MathNet.Numerics library is used for performing mathematical computations, including the Fast Fourier Transform (FFT).

- System.Windows.Forms.DataVisualization.Charting: The System.Windows.Forms.DataVisualization.Charting library is used for charting capabilities to visualize the transformed signal.

## Getting Started
### To use this project, follow these steps:
- Clone or download the repository to your local machine.

- Open the solution file (.sln) in Visual Studio.

- Build the solution to restore NuGet packages and compile the project.

- Run the application.

- Click the "Upload" button to select an image file.

- Click the "Continuous Fourier transform" button to perform the transform and visualize the result in the chart.

