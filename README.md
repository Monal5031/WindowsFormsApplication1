The test case data genarator.

Created on Visual studio 2015 update 3.

c#

.NET Framework 4.5.2

Can generate test data in a range u to v both inclusive.(even/odd) 
For n < 10000 directly copies the output to clipboard. For n>10000 creates a text file in D:/


<h3>issues</h3>:-
<ol type="disc">
<li>  For output less than 10000 it takes less than 1 sec to copy into the clipboard. For greater than 10000, it's just not doing         anything.(Stucking somewhere at 10%)

<li> Taking too much time to create txt files.
</ol>

Things to be added:-
<ol type"1">
<li>String return type
<li>Time improvements
<li>Generated Test case sorted in ascending/ descending
</ol>

Sourceforge:- <a href="https://sourceforge.net/projects/test-data-generator/?source=directory">Link to download .exe file of this project</a>

