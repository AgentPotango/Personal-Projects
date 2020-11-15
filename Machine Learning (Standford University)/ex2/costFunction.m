function [J, grad] = costFunction(theta, X, y)
%COSTFUNCTION Compute cost and gradient for logistic regression
%   J = COSTFUNCTION(theta, X, y) computes the cost of using theta as the
%   parameter for logistic regression and the gradient of the cost
%   w.r.t. to the parameters.

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
%
% Note: grad should have the same dimensions as theta
%

%calculate the hypothesis. 
hypothesis = sigmoid(X*theta);
%calculate the cost function - respect the dimensions. 
J = 1/m * sum(-y'*log(hypothesis) - (1-y)'*log(1-hypothesis));

%we don't have to use the sum term here as with vector calculations
%we'll have already have "Summed" the columns/vectors
%this outputs a  3x1 matrix. 
grad = 1/m * X' * (hypothesis - y);

% ====================== Print Plot ======================

%  Set options for fminunc
%options = optimoptions(@fminunc,'Algorithm','Quasi-Newton','GradObj', 'on', 'MaxIter', 400);

%  Run fminunc to obtain the optimal theta
%  This function will return theta and the cost 
%[theta, cost] = fminunc(@(t)(costFunction(t, X, y)), initial_theta, options);


% Print theta
%fprintf('Cost at theta found by fminunc: %f\n', cost);
%disp('theta:');disp(theta);

% Plot Boundary
%plotDecisionBoundary(theta, X, y);
% Add some labels 
%hold on;
% Labels and Legend
%xlabel('Exam 1 score')
%ylabel('Exam 2 score')
% Specified in plot order
%legend('Admitted', 'Not admitted')
%hold off;









% =============================================================

end
