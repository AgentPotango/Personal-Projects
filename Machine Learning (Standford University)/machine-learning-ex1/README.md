# Machine Learning Course by Standford University (Coursera)
Uploaded in this directory will be my completed exercises for the course demonstraing my proficiency in machine learning. <br><br>

**Exercise 1:** <br>
Supervised learning with functions for the cost function, gradient descent for multiple parameters, normal equations as well as the normalisation of the training set data. <br><br>

**Cost Function:**<br>
Implemented a cost function which takes multiple parameters and calculates the summation of the squared differences between the hypothesis (aka our prediction model applied to the training set) and the actual values. <br>
Included is the ability to plot the cost function against potential values for parameters as well as a graph displaying whether or not the cost function will converge. 
<br><br>

**Gradient Descent:**<br>
Implemented a gradient descent algorithm that can be used for multiple parameters. Provided the learning rate is small enough, gradient descent will converge to a result.<br>
However, the learning rate should be large enough to ensure timely convergence of the algorithm. Displayed alongside are contour plots and 3d plots to visual the gradient descent algorithm <br> <br>

**Normalisation:** <br>
Normalisation involved subtracting the mean and dividing by either the Max-Min or the standard deviation allowing for faster convergence of the gradient descent algorithm. <br> <br>
**Normal Equations:** <br> 
Normal equations function used to solve problems for small datasets (meaning features/parameters are < 20,000) which has O(n^3) speed.<br> 
Normal equations essential calculate the vector of parametera (Theta) as follows: <br> <br>
Where X = set of training examples augmented by the column vector of 1, ' = Transpose, y = column vector of output variables: <br>
Theta = inverse(X' * X) * X' * y <br><br>

**Comparisons:** <br>
Gradient Descent is more timely for larger datasets resulting in speed of O(kn^2), but requires many iterations and the identification of a reasonable learning rate where as normal equations require no iterations and identification of a learning rate is not needed. <br>
However, there are cases where normal equations will not work and for which gradient descent is the superior choice as will be demonstrated in future uploads. <br>
