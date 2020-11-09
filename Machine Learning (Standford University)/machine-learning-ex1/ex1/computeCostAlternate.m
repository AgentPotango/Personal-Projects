function J = computeCostAlternate(X, y, theta)
%COMPUTECOST Compute cost for linear regression
%   J = COMPUTECOST(X, y, theta) computes the cost of using theta as the
%   parameter for linear regression to fit the data points in X and y

% Initialize some useful values
m = length(y); % number of training examples
% You need to return the following variables correctly 
J = 0;

% ====================== YOUR CODE HERE ======================
% Instructions: Compute the cost of a particular choice of theta
%               You should set J to the cost.
for i = 1:m,
    %(AB)^T = B^TA^T
    %we want a prediction that is 1x1 hence we use 1x2 x 2x1 = 1x1
    %remember y(i) = 1x1
    predictSum = X(i,:)*theta;
    %predictSum = theta' * X(i,:); 
    squaredError = (predictSum-y(i)).^2;
    J  = J + sum(squaredError);
end
J =J * 1/(2*m);



% =========================================================================

end
