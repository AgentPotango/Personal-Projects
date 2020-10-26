%Uses the crossfold function to split the given trainingdata into 2 parts
%Finds the accuracy of the test data with respect to k

%training data = 200x256 matrix
%labels = 200x1 matrix

function [accuracy] = partC(trainingdata, labels)
[shuffleddata, shuffledlbls] = shufflerows(trainingdata, labels);
[train1, train1lbl, test1, test1lbl] = crossfold(1,2,shuffleddata,...
                                                 shuffledlbls);

accuracy = partB(train1, test1, train1lbl, test1lbl);

title('Test Data Accuracy with respect to K');








