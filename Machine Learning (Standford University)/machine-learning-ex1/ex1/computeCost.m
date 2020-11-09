function J = computeCost(X, y, theta)
%COMPUTECOST Compute cost for linear regression
%   J = COMPUTECOST(X, y, theta) computes the cost of using theta as the
%   parameter for linear regression to fit the data points in X and y

% Initialize some useful values
m = length(y); % number of training examples
predictions = X*theta;
sqrError = (predictions-y).^2;

% You need to return the following variables correctly 
J = 0;

% ====================== YOUR CODE HERE ======================
% Instructions: Compute the cost of a particular choice of theta
%               You should set J to the cost.
%For loop variation. 
%(AB)^T = B^TA^T
%we want a prediction that is 1x1 hence we use 1x2 x 2x1 = 1x1
%remember y(i) = 1x1
%hence, X(i,:) = [x_0 x_1;] (1x2) * [theta_0;theta_1](2x1) = 
% = [x_0*theta_0 + x1_theta_1]
%which is our hypotheis function. This is the reason X*theta works
%and why theta'*x (where x is a column vector does not as in the
%theory
%for i = 1:m,
    %predictSum = X(i,:)*theta; %1x2 * 2x1 = 1x1
    %predictSum = theta' * X(i,:)';%1x2*2x1 = 1x1 (
    %squaredError = (predictSum-y(i)).^2;
    %J  = J + sum(squaredError);
%end
%J =J * 1/(2*m);

J = 1/(2*m) * sum(sqrError);


% =========================================================================

end
