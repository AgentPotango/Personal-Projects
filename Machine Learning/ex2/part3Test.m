
%vals is a 2x1 matrix
%part3([3;6],3,maindata,100,benchmarkdata,100);

function [accuracy] = part3Test(valuesArray, featureNo, testData,...
                            noOfTestExamples, trainingThreshold, weights)

[test, ~] = part3A(testData, noOfTestExamples, valuesArray);
feature = extractmyfeatures(reshape(test(1,:),16,16),featureNo);

noOfFeatures = size(feature,2);
noOfTestingData = size(test,1);

testingFeatures = zeros(noOfTestingData,noOfFeatures);

for i=1:noOfTestingData
    testingFeatures(i,:) = extractmyfeatures(reshape(...
                            test(i,:),16,16),featureNo);
end                            

w = weights;
threshold = trainingThreshold;

data = zeros(noOfTestingData,noOfFeatures);

for i = 1:noOfTestingData
data(i,:) = testingFeatures(i,:);
end


%The first labels are 1 
%The second labels are 0
%for vals [3;8] ---> 3 -> 1, 8->0
target = [ones(noOfTestExamples, 1);zeros(noOfTestExamples,1)];
predictions = zeros(noOfTestingData,1);

for iteration = 1:1   
    errors = 0;
    for i = 1:noOfTestingData
        
        active = 0;
        x = data(i,:);
        targ = target(i,:);
                
        for j = 1:noOfFeatures
            active = active + (w(j)*x(j));
        end
        
        if active > threshold
			output=1;
		else
			output=0;
        end
        
        predictions(i,1) = output;
        if output ~= targ
            errors = errors +1;
        end

    end
    disp(['On Iteration ' num2str(iteration) ': There were ' ...
                  num2str(errors) ' Errors'])
    accuracy = ((noOfTestingData - errors)/noOfTestingData);
    disp(['Accuracy is ' num2str(accuracy*100) '%']);
    disp(['End of iteration ' num2str(iteration) ]);
 

end

[confusionMatrix, labels] = confusionmat(target, predictions)

