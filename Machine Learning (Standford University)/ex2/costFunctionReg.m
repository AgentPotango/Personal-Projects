function [J, grad] = costFunctionReg(theta, X, y, lambda)
%COSTFUNCTIONREG Compute cost and gradient for logistic regression with regularization
%   J = COSTFUNCTIONREG(theta, X, y, lambda) computes the cost of using
%   theta as the parameter for regularized logistic regression and the
%   gradient of the cost w.r.t. to the parameters. 

% Initialize some useful values
m = length(y); % number of training examples

% You need to return the following variables correctly 
J = 0;
grad = zeros(size(theta));

% ====================== YOUR CODE HERE ======================
% Instructions: Compute the cost of a particular choice of theta.
%               You should set J to the cost.
%               Compute the partial derivatives and set grad to the partial
%               derivatives of the cost w.r.t. each parameter in theta


%calculate the hypothesis. 
hypothesis = sigmoid(X*theta);

originalCost = 1/m * sum(-y'*log(hypothesis) - (1-y)'*log(1-hypothesis));
%calculate the regularized portion
regularisedCostTerm =  (lambda/(2*m))*sum(theta(2:end).^2);
%calculate the regularised cost function
%note 2:end means skipping the first theta(0) value which we don't
%regularize
J = originalCost + regularisedCostTerm;

%the original non-regularized gradient
originalGradient = 1/m * X'*(hypothesis - y);

%get the regularised term but remember to not regularize theta0!
regularizedGradientTerm = (lambda/m) * theta;
regularizedGradientTerm(1) = 0;

%2:end means skipping first row etc
%don't need to sum as it is "already" summed into the appropriate matrix we
%need
grad = originalGradient + regularizedGradientTerm;



% =============================================================

end
