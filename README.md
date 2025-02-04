# GPax
 
 ```mermaid
 classDiagram
    class GPACalculator {
        - double gpa_sum
        - int n
        - double maxGPA
        - double minGPA
        + void setGPA(double gpa)
        + double getGPAX()
        + double getMaxGPA()
        + double getMinGPA()
        + int getStudentCount()
    }

    class Form1 {
        - GPACalculator GPACalculator
        + void btnAD_Click(object sender, EventArgs e)
        + void btclear_Click(object sender, EventArgs e)
        + void UpdateUI()
    }

    GPACalculator "1" --> "*" Form1 : uses