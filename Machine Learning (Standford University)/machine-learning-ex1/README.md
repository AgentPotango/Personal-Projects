# Machine Learning Course by Standford University (Coursera)
<br>
Uploaded in this directory will be my completed exercises for the course demonstraing my proficiency in machine learning. 

**Exercise 1:** <br>
Supervised learning with functions for the cost function, gradient descent for multiple parameters and normal equations <br><br>
Covers implementing the cost function and gradient descent for multiple parameters as well as normalization of the the training sets.<br>
Normalisation involved subtracting the mean and dividing by either the Max-Min or the standard deviation allowing for faster convergence of the gradient descent algorithm. <br>
Also implemented is a normal equations fucntion used to solve problems for small datasets (meaning features/parameters are < 20,000) which has O(n^3) speed.<br> 
Normal equations essential calculate the vector of parametera (Theta) as follows: <br> <br>
Where X = set of training examples augmented by the column vector of 1, ' = Transpose, y = column vector of output variables: <br>
Theta = inverse(X' * X) * X' * y <br><br>
Gradient Descent is more timely for larger datasets resulting in speed of O(kn^2), but requires many iterations and the identification of a reasonable learning rate. <br>
However, there are cases where normal equations will not work and for which gradient descent is the superior choice as will be demonstrated in future uploads. <br>
